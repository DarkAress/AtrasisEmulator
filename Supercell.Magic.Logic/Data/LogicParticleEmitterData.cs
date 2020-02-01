namespace Supercell.Magic.Logic.Data
{
    using Supercell.Magic.Titan.CSV;

    public class LogicParticleEmitterData : LogicData
    {
        private int m_particleCount;
        private int m_emissionTime;
        private int m_minLife;
        private int m_maxLife;
        private int m_minHorizAngle;
        private int m_maxHorizAngle;
        private int m_minVertAngle;
        private int m_maxVertAngle;
        private int m_minSpeed;
        private int m_maxSpeed;
        private int m_startX;
        private int m_startY;
        private int m_startZ;
        private int m_targetedEndZ;
        private int m_gravity;
        private int m_inertia;
        private int m_slowdown;
        private int m_startScale;
        private int m_endScale;
        private int m_minRotate;
        private int m_maxRotate;
        private int m_particleFadeOutTime;
        private int m_startRadius;

        public LogicParticleEmitterData(CSVRow row, LogicDataTable table) : base(row, table)
        {
            // LogicParticleEmitterData.
        }

        public override void CreateReferences()
        {
            base.CreateReferences();

            this.m_particleCount = this.GetIntegerValue("ParticleCount", 0);
            this.m_emissionTime = this.GetIntegerValue("EmissionTime", 0);
            this.m_minLife = this.GetIntegerValue("MinLife", 0);
            this.m_maxLife = this.GetIntegerValue("MaxLife", 0);
            this.m_minHorizAngle = this.GetIntegerValue("MinHorizAngle", 0);
            this.m_maxHorizAngle = this.GetIntegerValue("MaxHorizAngle", 0);
            this.m_minVertAngle = this.GetIntegerValue("MinVertAngle", 0);
            this.m_maxVertAngle = this.GetIntegerValue("MaxVertAngle", 0);
            this.m_minSpeed = this.GetIntegerValue("MinSpeed", 0);
            this.m_maxSpeed = this.GetIntegerValue("MaxSpeed", 0);
            this.m_startX = this.GetIntegerValue("StartX", 0);
            this.m_startY = this.GetIntegerValue("StartY", 0);
            this.m_startZ = this.GetIntegerValue("StartZ", 0);
            this.m_targetedEndZ = this.GetIntegerValue("TargetedEndZ", 0);
            this.m_gravity = this.GetIntegerValue("Gravity", 0);
            this.m_inertia = this.GetIntegerValue("Inertia", 0);
            this.m_slowdown = this.GetIntegerValue("Slowdown", 0);
            this.m_startScale = this.GetIntegerValue("StartScale", 0);
            this.m_EndScale = this.GetIntegerValue("EndScale", 0);
            this.m_minRotate = this.GetIntegerValue("MinRotate", 0);
            this.m_maxRotate = this.GetIntegerValue("MaxRotate", 0);
            this.m_particleFadeOutTime = this.GetIntegerValue("ParticleFadeOutTime", 0);
            this.m_startRadius = this.GetIntegerValue("StartRadius", 0);
        }

        public int GetParticleCount()
        {
            return this.m_particleCount;
        }

        public int GetEmissionTime()
        {
            return this.m_emissionTime;
        }

        public int GetMinLife()
        {
            return this.m_minLife;
        }

        public int GetMaxLife()
        {
            return this.m_maxLife;
        }

        public int GetMinHorizAngle()
        {
            return this.m_minHorizAngle;
        }

        public int GetMaxHorizAngle()
        {
            return this.m_maxHorizAngle;
        }

        public int GetMinVertAngle()
        {
            return this.m_minVertAngle;
        }

        public int GetMaxVertAngle()
        {
            return this.m_maxVertAngle;
        }

        public int GetMinSpeed()
        {
            return this.m_minSpeed;
        }

        public int GetMaxSpeed()
        {
            return this.m_maxSpeed;
        }

        public int GetStartX()
        {
            return this.m_startX;
        }

        public int GetStartY()
        {
            return this.m_startY;
        }

        public int GetStartZ()
        {
            return this.m_startZ;
        }

        public int GetTargetedEndZ()
        {
            return this.m_targetedEndZ;
        }

        public int GetGravity()
        {
            return this.m_gravity;
        }

        public int GetInertia()
        {
            return this.m_inertia;
        }

        public int GetSlowdown()
        {
            return this.m_slowdown;
        }

        public int GetStartScale()
        {
            return this.m_startScale;
        }

        public int GetEndScale()
        {
            return this.m_endScale;
        }

        public int GetMinRotate()
        {
            return this.m_minRotate;
        }

        public int GetMaxRotate()
        {
            return this.m_maxRotate;
        }

        public int GetParticleFadeOutTime()
        {
            return this.m_particleFadeOutTime;
        }

        public int GetStartRadius()
        {
            return this.m_startRadius;
        }
    }
}
