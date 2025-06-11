using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22_Object
{
    internal class HocSinh
    {
        /// <summary>
        ///Auto-implemented thuộc tính được triển khai tự động
        #region Auto-implemented properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        #endregion

        #region methods tostring()
        public override string ToString()
        {
            return this.Name + " - " + this.Email + " - " + this.Phone;
        }

        #endregion
    }
}
