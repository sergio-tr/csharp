using System;

class Lasagna
{
    private static readonly int expectedMinutesInOven = 40;
    private static readonly int numberOfMinutesPerLayer = 2;

    public int ExpectedMinutesInOven() => expectedMinutesInOven;

    public int RemainingMinutesInOven( int actualMinutes ){

        if(actualMinutes > expectedMinutesInOven ){
            throw new ArgumentOutOfRangeException("The lasagna has already been overcooked");
        }

        return expectedMinutesInOven - actualMinutes;
    }

    public int PreparationTimeInMinutes( int layers ){
        if( layers < 0 ){
            throw new ArgumentOutOfRangeException("The number of layers");
        }

        return layers * numberOfMinutesPerLayer;
    }

    public int ElapsedTimeInMinutes(int layers, int actualMinutes) => PreparationTimeInMinutes(layers) + actualMinutes;


}
