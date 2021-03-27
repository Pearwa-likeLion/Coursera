import xml.etree.ElementTree as ET
import urllib.request, urllib.parse, urllib.error
from bs4 import BeautifulSoup
import ssl

total = 0
# Ignore SSL certificate errors
ctx = ssl.create_default_context()
ctx.check_hostname = False
ctx.verify_mode = ssl.CERT_NONE

url = input('Enter - ')
html = urllib.request.urlopen(url, context=ctx).read()
stuff = ET.fromstring(html)
comments  = stuff.findall('comments/comment')
print('Count:',len(comments))
for item in comments:
    num = item.find('count').text
    total = total + int(num)
print('Sum',total)
#http://py4e-data.dr-chuck.net/comments_1140217.xml
#http://py4e-data.dr-chuck.net/comments_42.xml
