using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    [Serializable]
    public class Boy : User
    {
        public Boy() : base()
        {

        }

        public Boy(string name, string account, int age, List<string> roles, DateTime birthday, ClassModel classInfo) : base(name, account, age, roles, birthday, classInfo)
        {

        }

        public override User Clone()
        {
            return this.MemberwiseClone() as Boy;
        }

        public override User DeepClone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return bf.Deserialize(ms) as Boy;
        }
    }
}
