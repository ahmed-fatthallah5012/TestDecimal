using System;

namespace TestDecimal.GenericTools
{
    public class DecimalsTool
    {
        private static Decimal _lasId = new Decimal();

        public static Decimal GetNewId()
        {
            string str = BitConverter.ToUInt64(Guid.NewGuid().ToByteArray(), 8).ToString();
            long ticks = DateTime.Now.Ticks;
            int length = 8;
            if (str.Length < 8)
                length = str.Length;
            //Decimal num = Decimal.Parse(string.Format("{0}.{1}", (object)ticks, (object)str.Substring(0, length)));
            Decimal num = Decimal.Parse($"{(object) ticks}.{(object) str.Substring(0, length)}");
            if (num == DecimalsTool._lasId)
                return DecimalsTool.GetNewId();
            DecimalsTool._lasId = num;
            return num;
        }
    }
}
