namespace FourRealms.Design.Dice
{
    /// <summary>
    /// D6系统
    /// </summary>
    public class D6
    {
        /// <summary>
        /// 获取或设置骰子数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置加值
        /// </summary>
        public int Add { get; set; }

        /// <summary>
        /// 投掷骰子
        /// </summary>
        /// <returns></returns>
        public int Throw()
        {
            return Throw(Count) + Add;
        }

        /// <summary>
        /// 投掷骰子
        /// </summary>
        /// <param name="count">骰子数量</param>
        /// <returns></returns>
        public static int Throw(int count)
        {
            return Dice.Throw(count, 6);
        }

        public override string ToString()
        {
            string str = string.Format("{0}D6", Count);
            if (0 > Add)
            {
                str += Add.ToString();
            }
            else if(0 < Add)
            {
                str += "+" + Add;
            }
            return str;
        }
    }
}
