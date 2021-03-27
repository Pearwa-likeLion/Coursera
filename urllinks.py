# To run this, download the BeautifulSoup zip file
# http://www.py4e.com/code3/bs4.zip
# and unzip it in the same directory as this file

import urllib.request, urllib.parse, urllib.error , re
from bs4 import BeautifulSoup
import ssl

# Ignore SSL certificate errors
ctx = ssl.create_default_context()
ctx.check_hostname = False
ctx.verify_mode = ssl.CERT_NONE

url = input('Enter - ')
html = urllib.request.urlopen(url, context=ctx).read()
soup = BeautifulSoup(html, 'html.parser')

# Retrieve all of the anchor tags
counts = 0
total = 0
strls = list()
tags = soup('span')
for tag in tags:
    #tags = tag.get('href', tag)
    #strls.append(tags)
    #print(type(strls))

   # Look at the parts of a tag
    #print ('TAG:',tag)
    #print ('URL:',tag.get('href', None))
    print ('Contents:',tag.contents[0])
    #print ('Attrs:',tag.attrs)
    total = total + int(tag.contents[0])
    #strls = tag.contents[0]
    counts = counts + 1
print('sum',total)
print('Count',counts)

#print(strls)

#total = 0

#for line in strls:
#    print(line)
#    stuff = re.findall('([0-9.]ß+)' ,line)
#    numlist.append(stuff)
#    print(type(numlist))

#    total = total + float(stuff)
#    print(stuff)
