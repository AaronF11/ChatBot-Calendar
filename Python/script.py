# Dependencies
def import_dependencies():
    try:
        import datetime
        import re
        return "Dependecias importadas"
    except ImportError as e:
        exception = ("Error: {0}".format(e))
        return exception

def example():
    import datetime
    import re
    return "Example"