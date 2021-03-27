#newcoding corect
    name = input("Enter file:")
if len(name) < 1 : name = "mbox-short.txt"
handle = open(name)
count = dict()
for line in handle:
    line = line.split()
    if len(line) < 1 :
        continue
    if line[0] != 'From' :
        continue
    lines = line[1].split(" ")
    #print(lines)
    for word in lines:
        count[word] = count.get(word,0) + 1
        #print(count.items())
bigcount = None
bigword = None
for word,count in count.items():
    if bigcount is None or count > bigcount:
        bigword = word
        bigcount = count
print(bigword,bigcount)

#oldcoding
#name = input("Enter file:")
#if len(name) < 1 : name = "mbox-short.txt"
#handle = open(name)
#wds = list()
#words = list()
#count = dict()
#for line in handle:
#    line = line.rstrip()
#    wds = line.split()
#    if len(wds) < 1 :
#        continue
#    if wds[0] != 'From' :
#        continue
#    words = wds[1]
#    print(words)
#    for word in words:
#        count[word] = count.get(word,0) + 1
#        print(count.items())
#bigcount = None
#bigword = None
#for word,count in count.items():
 #   if bigcount is None or count > bigcount:
  #      bigword = word
   #     bigcount = count
    #    print(bigword,bigcount)

    #for i in wds:
    #	count[i] = count.get(word,0) + 1
    #print()
    #for i in wds:
    #	count[i] = count.get(word,0) + 1
    #print()
