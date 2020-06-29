loaded_data = ""

def load_data(file_name):
    file = open(file_name,"r")
    content  = file.readlines()
    
    for line in content:
        if not line == None:
            return line
    
    return None

def on_start():
    loaded_data = load_data("data.txt")
    print(loaded_data)

on_start()
