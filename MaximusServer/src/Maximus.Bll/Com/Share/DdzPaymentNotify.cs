using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maximus.Bll.Logic;
using Maximus.Model;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Cache;
using ZyGames.Framework.Game.Com.Generic;
using ZyGames.Framework.Game.Pay;

namespace Maximus.Bll.Com.Share
{
    class DdzPaymentNotify : PaymentNotify
    {
        protected override bool DoNotify(int userId, OrderInfo orderInfo)
        {
            GameUser userInfo = new GameDataCacheSet<GameUser>().FindKey(userId.ToString());
            if (userInfo == null) return false;
            userInfo.PayGold = MathUtils.Addition(userInfo.PayGold, orderInfo.GameCoins);
            AchieveTask.SaveUserTask(userId.ToString(), TaskClass.ChongZhi, orderInfo.GameCoins);
            return true;
        }
    }
}
