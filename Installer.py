import os
import shutil
import winshell
import pygame
from win32com.client import Dispatch
import os
import time

pygame.init()


def set_text(string, coordx, coordy, fontSize):
    font = pygame.font.Font('freesansbold.ttf', fontSize)
    text = font.render(string, True, (255, 255, 255))
    textRect = text.get_rect()
    textRect.center = (coordx, coordy)
    return text, textRect

def set_side_text(string, coordx, coordy, fontSize):
    font = pygame.font.Font('freesansbold.ttf', fontSize)
    text = font.render(string, True, (255, 255, 255))
    textRect = text.get_rect()
    textRect.midleft = (coordx, coordy)
    return text, textRect


pygame.display.set_caption('StudyDash - Installation')
window = pygame.display.set_mode((500, 500))
window.fill((0, 255, 153))

totalText = set_text("----------START----------", 250, 30, 30)
window.blit(totalText[0], totalText[1])
pygame.display.update()
time.sleep(1)

base = 'StudyDash'
target = 'C:\\StudyDash'
try:
    shutil.copytree(base, target)
    dirstxt = set_text("Directories created and filled with necessary data", 250, 60, 15)
    window.blit(dirstxt[0], dirstxt[1])
    pygame.display.update()
    time.sleep(3)
except:
    dirstxt = set_text("Directory already exists! skipping directory creation.", 250, 60, 15)
    window.blit(dirstxt[0], dirstxt[1])
    pygame.display.update()
    time.sleep(3)
try:
    shutil.rmtree('StudyDash', ignore_errors=False, onerror=None)
    dirstxt = set_text("Removed unnecessary files", 250, 170, 15)
    window.blit(dirstxt[0], dirstxt[1])
    pygame.display.update()
except:
    foferror = set_text("The necessary files were not found,", 250, 120, 15)
    window.blit(foferror[0], foferror[1])
    pygame.display.update()
    dirstxt = set_text("please remove all previous files and", 250, 135, 15)
    window.blit(dirstxt[0], dirstxt[1])
    pygame.display.update()
    dirstxt = set_text("re-download, then, re-install", 250, 150, 15)
    window.blit(dirstxt[0], dirstxt[1])
    pygame.display.update()

desktop = winshell.desktop()
path = os.path.join(desktop, "StudyDash.lnk")
target = 'C:\\StudyDash\\bin\\Release\\net5.0-windows\\StudyDash.exe'
wDir = 'C:\\StudyDash\\bin\\Release\\net5.0-windows'
icon = 'C:\\StudyDash\\StudyDash\\AdditionalFiles\\Imagery\\Internal\\iconLogo.ico'

shell = Dispatch('WScript.Shell')

shortcut = shell.CreateShortCut(path)
shortcut.Targetpath = target
shortcut.WorkingDirectory = wDir
shortcut.IconLocation = icon
shortcut.save()
dirstxt = set_text("Successfully created/re-created desktop shortcut", 170, 290, 15)
window.blit(dirstxt[0], dirstxt[1])
pygame.display.update()

dirstxt = set_text("This window will close in  10 seconds", 250, 370, 15)
window.blit(dirstxt[0], dirstxt[1])
pygame.display.update()
i = 0

dirstxt = set_text("[                    ]", 250, 400, 30)
window.blit(dirstxt[0], dirstxt[1])
pygame.display.update()
for i in range(0,10):
    time.sleep(1)
    dirstxt = set_side_text("." * i, 170, 390, 60)
    window.blit(dirstxt[0], dirstxt[1])
    pygame.display.update()

