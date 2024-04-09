using System;

namespace Quan_Li_Thu_Vien
{
    internal class ObjectParameter
    {
        private string v;
        private Type type;

        public ObjectParameter(string v, Type type)
        {
            this.v = v;
            this.type = type;
        }

        public ObjectParameter(string v, string tenTG)
        {
            this.v = v;
        }

        public ObjectParameter(string v, int namSinh1)
        {
            this.v = v;
        }
    }
}