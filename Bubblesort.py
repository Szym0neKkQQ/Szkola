arr = [int] * 5

for i in range(5):
    while True:
        try:
            arr[i] = int(input("Write a number"))
            break
        except ValueError:
            print("Integer Only")

for i in range(5):
    for j in range(5):
        if (arr[i]<arr[j]):
            bubble = arr[i]
            arr[i] = arr[j]
            arr[j] = bubble

for i in range(len(arr)):
    print("%d" % arr[i])
