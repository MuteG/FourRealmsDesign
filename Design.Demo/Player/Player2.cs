/* *************************************************************************
 * Copyright (c)2012 NTT DATA BEEN (China) Information Technology Co.,Ltd.
 * 作成者  ：gaoyunpeng
 * 機能概要：
 * 改訂履歴：
 * 2012/9/26 11:52:26 新規 gaoyunpeng
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

    public class Player2 : AbstractPlayer
    {
        public Player2()
        {
            foreach (Hand hand in this.Hands)
            {
                hand.Hold(
                    new Sword()
                    {
                        Power = new D6() { Count = 1, Add = 0 },
                        Name = "鱼肠"
                    }
                    );
            }
            this.HP = D6.Throw(2);
            this.Sex = Life.Sex.Female;
            this.Name = "双刀火鸡";
        }
    }
}
