text = "X-DSPAM-Confidence:    0.8475";
data_z = text.find('0')
print(data_z)
data_f = text.find('5')
print(data_f)
data = float(text[data_z:data_f+1])
print(data)
