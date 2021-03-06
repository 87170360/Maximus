﻿import clr, sys
from action import *
from lang import Lang
clr.AddReference('Maximus.Lang')
clr.AddReference('Maximus.Model')
clr.AddReference('Maximus.Bll')
from Maximus.Lang import *
from Maximus.Model import *
from Maximus.Bll.Logic import *

class UrlParam(HttpParam):
    def __init__(self):
        HttpParam.__init__(self)
        self.HeadIcon = ''


class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)

def getUrlElement(httpGet, parent):
    urlParam = UrlParam();
    if httpGet.Contains("HeadIcon"):
        urlParam.HeadIcon = httpGet.GetStringValue("HeadIcon", 1, 50 )
    else:
        urlParam.Result = False;

    return urlParam;

def takeAction(urlParam, parent):
    actionResult = ActionResult()
    gameHall = GameHall(parent.Current.User)
    actionResult.Result = gameHall.ChangeUserHead(urlParam.HeadIcon)
    if not actionResult.Result:
        parent.ErrorCode = Lang.getLang("ErrorCode")
        parent.ErrorInfo = Lang.getLang("St1010_ChangeHeadError")
        return actionResult

    return actionResult;

def buildPacket(writer, urlParam, actionResult):

    return True;