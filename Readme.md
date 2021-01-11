# 매장 입점 지역 추천 시스템

# 개요
매출 데이터, 역세권 유동 인구 분석을 통한 매장 입점 지역 추천 시스템을 구현하였습니다.

# 개발기간
2020년 12월 28일 ~ 2021년 1월 8일

# 참여 인원
IoT기반 스마트팩토리 SW개발 전문가과정

김민경, 김창준, 이시언, 정상훈, 최보화 총 5명

# 개발 환경

### C# Cosmetic Solution Client project
Microsoft Visual Studio Community 2019 v16.8.2

#### 언어
- C# 8.0

#### 프레임워크

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

#### 라이브러리
DevExpress Chart Control v.20.2.4

#### 데이터베이스
Microsoft MS-SQL Server 2019

# 화면 목록
1. 추천 결과 화면
<img src="./Document/추천 결과 화면.jpg" width="80%">

연령별 매출 정보를 DB에서 추출하여 차트에 출력한다.

2. 경쟁 업체 매장 정보 화면
<img src="./Document/경쟁업체매장정보.jpg" width="80%">

추천된 역 주변의 경쟁 업체 매장 정보를 검색하고 출력한다.

3. 500M 이내 입점 추천 정보 화면
<img src="./Document/지하철역 반경 500M 주변 추천 정보 화면.jpg" width="80%">

지하철 역 주변의 500M 이내의 입점 추천 정보를 출력한다.

4. 입점 추천 점수 화면
<img src="./Document/입점 추천 점수.jpg" width="80%">

DB에서 지하철 유동인구수, 경쟁 업체 수, 매장 평수, 동일 브랜드 기존 입점 매장 수를 추출하고 항목별로 가중치를 부여한 점수를 구해서 매장 입점 추천 점수를 출력한다.

5. Open Close 시간 추천 화면
<img src="./Document/Open Close 시간 추천.jpg" width="80%">

지하철 역의 유동 인구 수가 출근 시간이 지난 후 다시 늘어나는 시간을 추출하여 매장의 Open, Close 시간을 추천한다.

6. 경쟁 업체 매장 정보KakaoMap 화면
<img src="./Document/경쟁업체매장정보KakaoMap.jpg" width="80%">

추천된 역 주변의 경쟁 업체 매장 정보를 검색하고 출력한다.(Kakao Map)

7. 월세 시세 검색 화면
<img src="./Document/월세 시세 검색.jpg" width="80%">

추천하는 지하철 역 주변의 월세 시세를 검색하고 출력한다.

# WinForm Classes

<img src="./Document/WinForm Classes.jpg" width="80%">

# DAO Classes

<img src="./Document/DAO Classes.jpg" width="80%">

# Model Classes

<img src="./Document/Model Classes.jpg" width="80%">


