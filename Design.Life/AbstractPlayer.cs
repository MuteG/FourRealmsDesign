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
            Hands.Add(new Hand() { Item = null, Position = HandPosition.Left });
            Hands.Add(new Hand() { Item = null, Position = HandPosition.Right });
            Sex = Life.Sex.Male;
        }

        public void Attack(AbstractPlayer target)
        {
            foreach (Hand hand in Hands)
            {
                if (hand.Item is AbstractWeapon)
                {
                    target.HP -= (hand.Item as AbstractWeapon).Attack();
                }
            }
        }
    }
}
