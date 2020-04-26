"""
Owner: Akil Aubeeluck
Email: aka@programmer.net

This script can be run using Windows Console or Terminal
A return value will be shown by executing the following command:
"python3 currentFile.py" which will return or show the value of temp.

For Example: "python3 currentFile.py 8 True True True" will return
a random text with length of 8 character including Upper Case, LowerCase
and Numbers.
"""
import sys
import random

def generateRandom(length, upperCase, lowerCase, numbers):
    temp = ""
    chars = ""

    if(upperCase == True):
        chars += "QWERTYUIOPASDFGHJKLZXCVBNM"
    
    if(lowerCase == True):
        chars += "qwertyuiopasdfghjklzxcvbnm"
    
    if(numbers == True):
        chars += "0123456789"

    for x in range(0, length):
        temp += chars[random.randrange(0, len(chars) - 1)]
    
    return temp

if __name__ == "__main__":
    
    leng = int(sys.argv[1])
    uCase = bool(sys.argv[2])
    lCase = bool(sys.argv[3])
    nums = bool(sys.argv[4])
    
    randomText = generateRandom(leng, uCase, lCase, nums) 
    print(randomText)