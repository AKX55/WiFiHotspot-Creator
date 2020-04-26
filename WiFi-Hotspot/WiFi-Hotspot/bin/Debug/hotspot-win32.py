"""
Owner: Akil Aubeeluck
Email: aka@programmer.net

This script can be run using Windows Console or Terminal
"python3 currentFile.py" which will create logs for connection status.

Example: "python currentFile.py WifiName WifiKey001" will create a 
WiFi Hotspot of name 'WiFiName' and Password 'WifiKey001'
"""
import sys
import subprocess

from datetime import date
from datetime import time
from datetime import datetime

arg_supportstatus = "netsh wlan show drivers"
arg_configurehotspot = "netsh wlan set hostednetwork mode=allow ssid={0} key={1}"
arg_starthotspot = "netsh wlan start hostednetwork"
arg_stophotspot = "netsh wlan stop hostednetwork"

msg_support = "Hosted network supported  : Yes"
msg_config = "hosted network has been successfully changed"
msg_launched = "The hosted network started."
msg_stopped = "The hosted network stopped."

def startHotspot(ssid, key):

        is_supported = msg_support in str(subprocess.check_output(arg_supportstatus, shell=True))
        if(is_supported):
            print("[OK][{0}] Hotspot Supported".format(datetime.time(datetime.now())))            
            try:
                is_condigured = msg_config in str(subprocess.check_output(arg_configurehotspot.format(ssid, key), shell = True))
                if(is_condigured):
                    print("[OK][{0}] Hotspot Configured".format(datetime.time(datetime.now())))
                    
                    is_launched = msg_launched in str(subprocess.check_output(arg_starthotspot, shell = True))
                    if(is_launched):
                        print("[OK][{0}] Hotspot Started".format(datetime.time(datetime.now())))
                    else:
                        print("[ER][{0}] Hotspot Failed to Start!".format(datetime.time(datetime.now())))
                else:
                    print("[ER][{0}] Hotspot Failed to Configure!".format(datetime.time(datetime.now())))
            except:
                print("[ER][{0}] Hotspot Service Failed! Try Run as Admin".format(datetime.time(datetime.now())))
        else:
            print("[ER][{0}] Hotspot Not Supported on WiFi Card".format(datetime.time(datetime.now())))

def stopHotspot():

    is_stopped = msg_stopped in str(subprocess.check_output(arg_stophotspot, shell=True))
    if(is_stopped):
        print("[OK][{0}] Hotspot Stopped".format(datetime.time(datetime.now())))                        
    else:
        print("[ER][{0}] Hotspot Failed to Stop".format(datetime.time(datetime.now())))

if __name__ == "__main__":
    
    mode = sys.argv[1]
    if("start" in mode):

        ssid = sys.argv[2]
        key = sys.argv[3]
        startHotspot(ssid, key)
    elif("stop" in mode):

        stopHotspot()
    else:

        print("[ER][{0}] Argument not recognised".format(datetime.time(datetime.now())))