import re
handle = open('regex_sum_1140213.txt')
total = 0
count = 0
counts = 0
numlist = list()
for line in handle:
    line = line.rstrip()
    stuff = re.findall('([0-9]+)',line)
    if len(stuff) == 0: continue
    print(stuff, counts)
    counts = counts + 1
    for i in stuff:
        numlist.append(i)
        count = count + 1
for ele in range(0, len(numlist)):
    total = total + float(numlist[ele])
print(int(total))
