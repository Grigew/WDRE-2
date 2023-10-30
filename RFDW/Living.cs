using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFDW
{
    internal class Living : GameObject2
    {
        #region Properties
        public float Speed { get; protected set; } = 2.0f;
        public float Hp { get; protected set; }
        public float Hunger { get; protected set; }
        public float Damage { get; protected set; }
        #endregion
    }
}
