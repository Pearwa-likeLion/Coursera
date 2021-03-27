import urllib.request, urllib.parse, urllib.error
import json
import ssl

total = 0
# Ignore SSL certificate errors
ctx = ssl.create_default_context()
ctx.check_hostname = False
ctx.verify_mode = ssl.CERT_NONE
while True:
    url = input('Enter - ')
    if len(url) < 1: break
    connection = urllib.request.urlopen(url, context=ctx).read()
    data = connection.decode()
    js = json.loads(data)

    for i in js['comments']:
        num = i['count']
        print(num)
        total = total + int(num)
    print('Sum',total)
#http://py4e-data.dr-chuck.net/comments_1140218.json
#http://py4e-data.dr-chuck.net/comments_42.json
