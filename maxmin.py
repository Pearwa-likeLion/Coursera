largest = None
smallest = None
while True:
    num = input('Enter a number: ')
    if num == 'done': break
    try:
        numf = float(num)
    except:
        print('Invaild input')
    if smallest is None :
        smallest = numf
    if largest is None :
        largest = numf
    elif numf < smallest :
        smallest = numf
    elif numf > largest :
        largest = numf

    print(numf,smallest,largest)
