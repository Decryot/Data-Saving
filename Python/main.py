loaded_data = ""

def load_data(file_name):
    file = open(file_name,"r")
    lines  = file.read()
    
    print(lines)
    if not lines == None:
        return lines
    
    return None

def on_start():
    loaded_data = load_data("data.txt")
    print(loaded_data)

on_start()