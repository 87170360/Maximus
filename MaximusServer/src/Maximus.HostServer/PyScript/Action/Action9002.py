import clr, sys
from action import *
from System import *
from mathUtils import MathUtils
from lang import *

clr.AddReference('ZyGames.Framework');
clr.AddReference('ZyGames.Framework.Common');
clr.AddReference('ZyGames.Framework.Game');
clr.AddReference('Maximus.Bll');
clr.AddReference('Maximus.Model');
clr.AddReference('Maximus.Lang');
from System.Collections.Generic import *
from ZyGames.Framework.SyncThreading import *
from ZyGames.Framework.Common import *
from ZyGames.Framework.Game.Cache import *
from ZyGames.Framework.Game.Com.Rank import *
from ZyGames.Framework.Game.Service import *
from Maximus.Bll import *
from Maximus.Bll.Logic import *
from Maximus.Bll.Com.Chat import *
from Maximus.Lang import *
from Maximus.Model import *
from ZyGames.Framework.Cache.Generic import *
from ZyGames.Framework.Game.Runtime import *
from ZyGames.Framework.Cache import *


#聊天发送接口
class UrlParam(HttpParam):
    def __init__(self):
        HttpParam.__init__(self)
        self.ChatID = 0

class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)
        self.userRankList = List[UserRank]
        self.PageCount = 0

def getUrlElement(httpGet, parent):
    urlParam = UrlParam()
    if httpGet.Contains("ChatID"):
        urlParam.ChatID = httpGet.GetIntValue("ChatID")
    else:
        urlParam.Result = False

    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult();
    user = parent.Current.User;
    table = GameRoom.Current.GetTableData(user)
    if not table or not user:
        parent.ErrorCode = Lang.getLang("ErrorCode");
        parent.ErrorInfo = Lang.getLang("St9002_NotJoinedTheRoom");
        actionResult.Result = False;
        return actionResult;
    chatinfo = ConfigCacheSet[ChatInfo]().FindKey(urlParam.ChatID)
    if chatinfo:
        chatService = DdzChatService(user)
        chatService.Send(ChatType.Whisper,chatinfo.Id, chatinfo.Content);
        GameTable.Current.SyncNotifyAction(ActionIDDefine.Cst_Action9003,table, None,None)
    return actionResult;

def buildPacket(writer, urlParam, actionResult):
    return True;