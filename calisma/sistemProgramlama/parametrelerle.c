#include <stdlib.h>
#include <stdio.h>

int main(int argc, char const *argv[])
{
    if (argc < 2)
    {
        printf("Program kullanimi %s ..parametreler\n", argv[0]);
        exit(1);
    }
    
        printf("calistirilan pogram %s \n", argv[0]);
        printf("parametre sayisi %d\n", argc -1 );
        printf("parametreler ");
        for (int i = 1; i < argc; i++)
        {
            printf("%s ", argv[i]);
        }
        /*
        printf("calistirilan pogram %s \n", *argv);
        printf("parametre sayisi %d\n", argc - 1);
        printf("parametreler ");
        for (int i = 1; i < argc; i++) {
          printf("%s ", *++argv);
        }
        */
        /*
        printf("calistirilan pogram %s \n", *argv);
        printf("parametre sayisi %d\n", argc - 1);
        printf("parametreler ");
        for (; *argv; ++argv) {
          printf("%s ", *++argv);
        }
        */
        
      
    
    return 0;
}
