#ifndef MAX_H
#define MAX_H

#include <string>
#include <iostream>
#include <cstring>
#include <cstdlib>
#include <cstdio>
#include <array>

using namespace std;

#ifdef __cplusplus
extern "C" {
#endif

#ifdef MAX
#define MAX __declspec(dllexport)
#else
#define MAX __declspec(dllimport)
#endif

int MAX Max(int a, int b);

#ifdef __cplusplus
}
#endif

#endif