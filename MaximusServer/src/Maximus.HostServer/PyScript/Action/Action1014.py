﻿"""1014_用户信息变更通知接口"""
import clr, sys
from action import *
clr.AddReference('ZyGames.Framework.Game')
clr.AddReference('Maximus.Lang')
clr.AddReference('Maximus.Model')
clr.AddReference('Maximus.Bll')
from ZyGames.Framework.Game.Service import *
from Maximus.Lang import *
from Maximus.Model import *
from Maximus.Bll.Logic import *
from Maximus.Bll.Base import *

class UrlParam(HttpParam):
    def __init__(self):
        HttpParam.__init__(self)


class ActionResult(DataResult):
    def __init__(self):
        DataResult.__init__(self)
        self.HeadIcon = ''
        self.GameCoin = 0
        self.Gold = 0
        self.VipLv = 0
        self.WinNum = 0
        self.FailNum = 0
        self.TitleName = ''
        self.ScoreNum = 0


def getUrlElement(httpGet, parent):
    urlParam = UrlParam()
    if True:
        urlParam.Result = True
    else:
        urlParam.Result = False

    return urlParam

def takeAction(urlParam, parent):
    gameRoom = GameRoom.Current
    actionResult = ActionResult();
    actionResult.Rooms = gameRoom.RoomList
    user = parent.Current.User;
    if user:
        gameHall = GameHall(user)
        actionResult.HeadIcon = user.HeadIcon
        actionResult.GameCoin = user.GameCoin
        actionResult.Gold = gameHall.UserGold
        actionResult.VipLv = user.VipLv
        actionResult.WinNum = user.WinNum
        actionResult.FailNum = user.FailNum
        actionResult.TitleName = gameHall.GetTitle()
        actionResult.ScoreNum = user.ScoreNum
    else:
        parent.ErrorCode = LanguageManager.GetLang().ErrorCode
        parent.ErrorInfo = LanguageManager.GetLang().LoadDataError
        actionResult.Result = False
        return actionResult
    return actionResult;

def buildPacket(writer, urlParam, actionResult):
    writer.PushIntoStack(actionResult.HeadIcon)
    writer.PushIntoStack(actionResult.GameCoin)
    writer.PushIntoStack(actionResult.Gold)
    writer.PushIntoStack(actionResult.VipLv)
    writer.PushIntoStack(actionResult.WinNum)
    writer.PushIntoStack(actionResult.FailNum)
    writer.PushIntoStack(actionResult.TitleName)
    writer.PushIntoStack(actionResult.ScoreNum)

    return True