//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CosmeticSolutionFinal.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class InformationNearStation
    {
        public int Id { get; set; }
        public int StationId { get; set; }
        public int NumberOfCompetitorStore { get; set; }
        public int BuildArea { get; set; }
        public int NumberOfStore { get; set; }

        public string GetFormattedStringNumberOfCompetitor()
        {
            int score = 0;
            if (NumberOfCompetitorStore <= 1)
                score = 5;
            else if (NumberOfCompetitorStore <= 5)
                score = 4;
            else if (NumberOfCompetitorStore <= 10)
                score = 3;
            else if (NumberOfCompetitorStore <= 15)
                score = 2;
            else if (NumberOfCompetitorStore <= 20)
                score = 1;
            else if (NumberOfCompetitorStore > 20)
                score = 0;

            return string.Format($"{NumberOfCompetitorStore} 개 ({score} 점)");
        }

        public int GetScoreNumberOfCompetitor()
        {
            int score = 0;
            if (NumberOfCompetitorStore <= 1)
                score = 5;
            else if (NumberOfCompetitorStore <= 5)
                score = 4;
            else if (NumberOfCompetitorStore <= 10)
                score = 3;
            else if (NumberOfCompetitorStore <= 15)
                score = 2;
            else if (NumberOfCompetitorStore <= 20)
                score = 1;
            else if (NumberOfCompetitorStore > 20)
                score = 0;

            return score;
        }

        public string GetFormattedStringBuildArea()
        {
            int score = 0;

            if (BuildArea <= 15)
                score = 8;
            else if (BuildArea <= 20)
                score = 10;
            else if (BuildArea <= 30)
                score = 12;
            else if (BuildArea <= 40)
                score = 15;
            else if (BuildArea <= 50)
                score = 18;
            else if (BuildArea > 51)
                score = 20;

            return string.Format($"{BuildArea} 개 ({score} 점)");
        }

        public int GetScoreBuildArea()
        {
            int score = 0;

            if (BuildArea <= 15)
                score = 8;
            else if (BuildArea <= 20)
                score = 10;
            else if (BuildArea <= 30)
                score = 12;
            else if (BuildArea <= 40)
                score = 15;
            else if (BuildArea <= 50)
                score = 18;
            else if (BuildArea > 51)
                score = 20;

            return score;
        }

        public string GetFormattedStringNumberOfStore()
        {
            int score = 0;

            if (NumberOfStore <= 1)
                score = 10;
            else if (NumberOfStore <= 2)
                score = 5;
            else if (NumberOfStore > 2)
                score = 1;

            return string.Format($"{NumberOfStore} 개 ({score} 점)");
        }

        public int GetScoreNumberOfStore()
        {
            int score = 0;

            if (NumberOfStore <= 1)
                score = 10;
            else if (NumberOfStore <= 2)
                score = 5;
            else if (NumberOfStore > 2)
                score = 1;

            return score;
        }

        public virtual Station Station { get; set; }
    }
}
