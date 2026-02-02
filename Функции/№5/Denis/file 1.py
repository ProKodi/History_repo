





def decor(func):
    def decorate(*args, **kwargs):
        return f"{func(*args, **kwargs)} - {colors[decorate]}"
    return decorate


@decor
def red():
    return 'Color is red'

@decor
def green():
    return 'Color is green'

@decor
def blue():
    return 'Color is blue'


colors = {}
colors[green] = '00FF00'
colors[blue] = '0000FF'
colors[red] = 'FF0000'

for i in colors:
    print(i())