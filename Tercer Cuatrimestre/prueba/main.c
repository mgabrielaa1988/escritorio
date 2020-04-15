#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num=50, i;
    for(i=1; i<=num; i++)
    {
        if( !( num % i))
        {
            printf("%d\n", i);
        }
    }

    printf("\n\n");

    for(i=1; i<=num; i++)
    {
        if( num % i)
        {
            continue;
        }
        printf("%d\n", i);
    }

    printf("\n\n");

    int *p, *q;
    int x = 4;
    p = &x;
    q = p;
    *q += 3;
    printf("%d", *p);
    printf("\n%d,%d,%d",p,q,&x);

    printf("\n\n");

    int vec[ ] = {2,4,5,3,6,3,4,9};
    printf("%d", *(vec + (2*2)));

    return 0;
}
