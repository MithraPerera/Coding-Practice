"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language: https://en.wikipedia.org/wiki/Guido_van_Rossum
"""

EXPECTED_BAKE_TIME = 40
PREPARATION_TIME = 2


def bake_time_remaining(min_in_oven):
    """Calculate the bake time remaining.

    :param elapsed_bake_time: int - baking time already elapsed.
    :return: int - remaining bake time (in minutes) derived from 'EXPECTED_BAKE_TIME'.

    Function that takes the actual minutes the lasagna has been in the oven as
    an argument and returns how many minutes the lasagna still needs to bake
    based on the `EXPECTED_BAKE_TIME`.
    """
    return EXPECTED_BAKE_TIME - min_in_oven


def preparation_time_in_minutes(layers):
    """Return the preparation time based on the number of layers.

    Takes in a parameter for the number of layers and returns the total prep time.
    """
    return layers * PREPARATION_TIME


def elapsed_time_in_minutes(number_of_layers, elapsed_bake_time):
    """Returns the to time taken so far.

    Args:
        number_of_layers (int): number of layers in lasagna.
        elapsed_bake_time (int): how long has passed so far in baking time.

    Returns:
        int: total amount of time taken so far.
    """
    return preparation_time_in_minutes(number_of_layers) + elapsed_bake_time