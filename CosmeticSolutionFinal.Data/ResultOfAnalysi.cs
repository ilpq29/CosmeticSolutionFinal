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
    
    public partial class ResultOfAnalysi
    {
        public int ResultOfAnalysisId { get; set; }
        public System.DateTime AnalizedAt { get; set; }
        public int StationId { get; set; }
        public int ScoreOfWomenRatio { get; set; }
        public int ScoreOfCompetitorStore { get; set; }
        public int ScoreOfStoreSpace { get; set; }
        public int ScoreOfBranchNumber { get; set; }
    
        public virtual Station Station { get; set; }
    }
}
