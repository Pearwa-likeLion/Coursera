name = input("Enter file:")
if len(name) < 1 : name = "mbox-short.txt"
handle = open(name)
count = dict()
for line in handle:
    line = line.rstrip().split()
    if len(line) < 1: continue
    if line[0] != 'From' : continue
    line = line[5].split(":")
    line = line[0].split(" ")
    #print(line)

    for word in line:
        count[word] = count.get(word,0) + 1
        #print(count.items())

for k,v in sorted(count.items()):
    print(k,v)
