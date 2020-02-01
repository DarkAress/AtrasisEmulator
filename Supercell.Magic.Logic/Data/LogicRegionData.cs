namespace Supercell.Magic.Logic.Data
{
    using Supercell.Magic.Titan.CSV;

    public class LogicRegionData : LogicData
    {
        private string m_displayName;

        private bool m_isCountry;
        private bool m_hS;

        public LogicRegionData(CSVRow row, LogicDataTable table) : base(row, table)
        {
            // LogicRegionData.
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.this.m_displayName = this.GetValue("DisplayName", 0);
            this.m_isCountry = this.GetBooleanValue("IsCountry", 0);
            this.m_hS = this.GetBooleanValue("HS", 0);
        }

        public String GetDisplayName()
        {
          return this.m_displayName;
        }

        public bool IIsCountry()
        {
          return this.m_isCountry;
        }

        public bool IsHS()
        {
          return this.m_hS;
        }
    }
}
