def load_data():
    loaded_data = []
    try:
        file = open("data.txt","r")
        for line in file:
            loaded_data.append(line)
    except:
        print("file doesn't exist - def load_data")
        return None

    return loaded_data

def save_data(data):
    try:
        file = open("data.txt", "w+")
        file.write(str(data))
    except:
        print("file doesn't exist - def save_data")

save_data(100)
data = load_data()

for dat in data:
    print(dat)
