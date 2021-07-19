import os
import hashlib
src = 'C:/ittra/tests' 
files = os.listdir(src) 
while files:
	filesa = files.pop(-1)
	handle = open("C:/ittra/tests/"+filesa)
	handler = handle.read()
	print(filesa+" "+ hashlib.sha3_256(handler.encode('ascii')).hexdigest())
    

  










