g++ -c -DSUM max.cpp
g++ -shared -o max.dll max.o -Wl,--out-implib,max.a