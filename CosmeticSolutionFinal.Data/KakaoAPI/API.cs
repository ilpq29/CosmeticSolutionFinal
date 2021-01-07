using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CosmeticSolutionFinal.Data
{
    static class API
    {
        internal static List<Location> Search(string query)
        {
            List<Location> mls = new List<Location>();

            string site = "https://dapi.kakao.com/v2/local/search/address.json";
            string rquery = string.Format("{0}?query={1}", site, query);
            WebRequest request = WebRequest.Create(rquery); // REST API를 C#에서 사용하기 위한 개체생성

            string rkey = "[1cc40a7698335d52b01128860ef43cd3]"; // RESTAPI key 입력
            string header = "KakaoAK" + rkey; // WebRequest 개체의 헤더에 인증키를 포함
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse(); // WebRequest 개체를 통해 서비스를 요청하며, GetResponse 메서드를 호출하여 결과를 확인할 수 있게 WebRequest 개체를 반환하며 리턴하기
            Stream stream = response.GetResponseStream(); // Stream 개체를 참조한 후에 UTF8 인코딩 방식으로 StreamReader 개체를 만든 후에 그 결과를 ReadToEnd를 사용하여 문자열로 확인 할수 있다. 
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer(); // JSON 방식으로 받는 내용을 분석하기 위해 개체 사용.

            dynamic dob = js.Deserialize<dynamic>(json); // Runtime에 개체를 확인하기 위해 dynamic을 이용하여 이를 역직렬화하기. 
            dynamic docs = dob["documents"]; // 카카오 REST API에 키워드로 장소를 검색하기위해 documents[]있는 요소들을 java script에 있는것을 확인 할수 있다. 이를 가져오기 위해서 documents형식을 docs라는 변수로 참조. 

            object[] buf = docs; // docs는 요소의 컬렉션임으로 object[]로 변환한 후 원소 개수를 가져올수 있다. 
            int length = buf.Length;
            for (int i = 0; i < length; i++)
            {
                string Iname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new Location(Iname, x, y));
            }
            return mls;
        }
    }
}
