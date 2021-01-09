//------------------------------------------------------------------------------
// <auto-generated>
//     �� �ڵ�� ���ø����� �����Ǿ����ϴ�.
//
//     �� ������ �������� �����ϸ� ���� ���α׷����� ����ġ ���� ������ �߻��� �� �ֽ��ϴ�.
//     �� ������ �������� �����ϸ� �ڵ尡 �ٽ� ������ �� ���� ������ ����ϴ�.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CosmeticSolutionFinal.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Station()
        {
            this.Branches = new HashSet<Branch>();
            this.InformationNearStations = new HashSet<InformationNearStation>();
            this.PassengerInfoes = new HashSet<PassengerInfo>();
            this.ResultOfAnalysis = new HashSet<ResultOfAnalysi>();
        }
    
        public int StationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch> Branches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformationNearStation> InformationNearStations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PassengerInfo> PassengerInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultOfAnalysi> ResultOfAnalysis { get; set; }
    }
}
