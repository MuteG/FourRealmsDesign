/* *************************************************************************
 * Copyright (c)2012 NTT DATA BEEN (China) Information Technology Co.,Ltd.
 * 作成者  ：gaoyunpeng
 * 機能概要：
 * 改訂履歴：
 * 2012/9/26 11:22:01 新規 gaoyunpeng
 * *************************************************************************/
namespace FourRealms.Design.Life
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FourRealms.Design.Item.Weapon;

    public class AbstractPlayer
    {
        private int _HP;
        /// <summary>
        /// 获取或设置生命点数
        /// </summary>
        public int HP
        {
            get { return _HP; }
            set { SetHP(value); }
        }

        private void SetHP(int value)
        {
            _HP = value;
            if (0 > _HP)
            {
                _HP = 0;
            }
        }

        public Sex Sex { get; set; }

        /// <summary>
        /// 获取或设置名称
        /// </summary>
        public string Name { get; set; }

        public HandCollection Hands { get; set; }

        public AbstractPlayer()
        {
            Hands = new HandCollection();
            Hands.Add(new Hand() { Item = null, Position = HandPosition.Left });
            Hands.Add(new Hand() { Item = null, Position = HandPosition.Right });
            Sex = Life.Sex.Male;
        }

        public void Attack(AbstractPlayer target)
        {
            int originalHP = target.HP;
            foreach (Hand hand in Hands)
            {
                if (null != hand.Item &&
                    hand.Item is AbstractWeapon)
                {
                    target.HP -= (hand.Item as AbstractWeapon).Attack();
                }
            }
            int hurt = originalHP - target.HP;
            if (0 == target.HP)
            {
                Console.WriteLine("{0} 造成 {2}点伤害 => {1}(死亡)", Name, target.Name, hurt);
            }
            else
            {
                Console.WriteLine("{0} 造成 {4}点伤害 => {1}({2} -> {3})",
                    Name, target.Name, originalHP, target.HP, hurt);
            }
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("玩家：{0}({1})", Name, HP);
            strBuilder.AppendLine();
            foreach (Hand hand in Hands)
            {
                string message = string.Empty;
                switch (hand.Position)
                {
                    case HandPosition.Left:
                        message += "左手";
                        break;
                    case HandPosition.Right:
                        message += "右手";
                        break;
                }
                if (hand.Item == null)
                {
                    message += "空手";
                }
                else
                {
                    message += string.Format("拿着 {0} 的 {1}", (hand.Item as AbstractWeapon).Power, hand.Item.Name);
                }
                strBuilder.AppendLine(message);
            }
            return strBuilder.ToString();
        }
    }
}
