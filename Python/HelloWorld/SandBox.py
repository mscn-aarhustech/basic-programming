"""
A tiny Python program that demonstrates:
- values & data types
- variables
- branching (if/else)
- loops
- functions
- documenting functions with docstrings
"""

# --- Values, variables, and data types ---
greeting = "Hello"          # string
times_to_repeat = 3         # integer
pi_value = 3.14             # float
is_learning_python = True   # boolean

print(greeting, "world!")   # classic hello world


# --- Branching (if / else) ---
if is_learning_python:
    print("Great! You're learning Python.")
else:
    print("Let's get started.")


# --- Looping ---
for i in range(times_to_repeat):
    print(f"Loop {i+1}: Python is fun!")


# --- Functions ---
def introduce(name, age):
    """
    Introduce a person with their name and age.

    Parameters:
        name (str): The person's name.
        age (int): The person's age.

    Returns:
        str: A friendly introduction message.
    """
    return f"My name is {name} and I am {age} years old."


# Calling the function
message = introduce("Alice", 25)
print(message)
