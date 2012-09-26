/* *************************************************************************
 * Copyright (c)2012 NTT DATA BEEN (China) Information Technology Co.,Ltd.
 * 作成者  ：gaoyunpeng
 * 機能概要：
 * 改訂履歴：
 * 2012/9/26 11:10:06 新規 gaoyunpeng
 * *************************************************************************/
namespace FourRealms.Design.Item.Weapon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FourRealms.Design.Dice;

    /// <summary>
    /// 抽象武器
    /// </summary>
    public class AbstractWeapon : AbstractItem
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        public D6 Power { get; set; }

        public AbstractWeapon()
        {
            Power = new D6() { Count = 1, Add = 0 };
        }

        public virtual int Attack()
        {
            return this.Power.Throw();
        }
    }
}
