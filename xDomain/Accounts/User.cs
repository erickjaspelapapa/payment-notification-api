namespace xDomain._91128
{
    public class User : BaseEntity
    {
        public string firstNm { get; set; }
        public string middleNm { get; set; }
        public string lastNm { get; set; }
        public string addressTx { get; set; }       
        public string contactTx { get; set; }
        /*System Security*/
        public string usernameTx { get; set; }
        public string passwordTx { get; set; }
        public string emailTx { get; set; }
        public string employeeNo { get; set; }
        public bool isActive_yn { get; set; }
        /*End Security*/

        public virtual List<AccessLevel>? AccessLevels { get; set; } 
    }
}
