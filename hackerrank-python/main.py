#!/bin/python3

import math
import os
import random
import re
import sys
import sherlock

fptr = sys.stdout

if __name__ == '__main__':

    s = input()

    result = sherlock.isValid(s)

    fptr.write(result + '\n')

    fptr.close()
