/* *************************************************************************
 * Copyright (c)2012 NTT DATA BEEN (China) Information Technology Co.,Ltd.
 * 作成者  ：gaoyunpeng
 * 機能概要：
 * 改訂履歴：
 * 2012/9/26 11:41:18 新規 gaoyunpeng
 * *************************************************************************/
namespace FourRealms.Design.Demo.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FourRealms.Design.Dice;
    using FourRealms.Design.Life;
    using FourRealms.Design.Item.Weapon;

    public class Player1 : AbstractPlayer
    {
        public Player1()
        {
            this.Hands.Remove(HandPosition.Left);
            foreach (Hand hand in this.Hands)
            {
                hand.Hold(
                    new Sword()
                    {
                        Power = new D6() { Count = 1, Add = 3 },
                        Name = "刑天"
                    }
                    );
            }
            this.HP = D6.Throw(2);
            this.Name = "独臂神爹";
        }
    }
}
