﻿"""2011_托管接口"""
import clr, sys
from action import *
from lang import Lang
clr.AddReference('ZyGames.Framework.Game')
clr.AddReference('Maximus.Lang')
clr.AddReference('Maximus.Model')
clr.AddReference('Maximus.Bll')
from ZyGames.Framework.Game.Service import *
from Maximus.Lang import *
from Maximus.Model import *
from Maximus.Bll.Logic import *

class UrlParam(HttpParam):
    def __init__(self):
        HttpParam.__init__(self)
        self.Op = 0


class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)


def getUrlElement(httpGet, parent):
    urlParam = UrlParam()
    if httpGet.Contains("Op"):
        urlParam.Op = httpGet.GetIntValue("Op")
    else:
        urlParam.Result = False

    return urlParam

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    user = parent.Current.User
    table = GameRoom.Current.GetTableData(user)
    if not user:
        parent.ErrorCode = Lang.getLang("ErrorCode")
        parent.ErrorInfo = Lang.getLang("LoadError")
        actionResult.Result = False
        return actionResult
    if not table:
        parent.ErrorCode = 1
        parent.ErrorInfo = Lang.getLang("St2011_Gameover")
        actionResult.Result = False
        return actionResult
    position = GameTable.Current.GetUserPosition(user, table)
    if not position:
        parent.ErrorCode = 1
        parent.ErrorInfo = Lang.getLang("St2011_Gameover")
        actionResult.Result = False
        return actionResult

    position.IsAI = urlParam.Op == 1 and True or False
    GameTable.Current.NotifyAutoAiUser(user.UserId, position.IsAI)
    return actionResult

def buildPacket(writer, urlParam, actionResult):

    return True