#pragma once
#include <cstdint>
#include <map>
#include <mutex>
#include <vector>
#include <stack>
#include <queue>
#include <iostream>
#include <cassert>
#include <functional>
#include <cstdio>
#include <cstdarg>
#include <utility>
#include <filesystem>
#include <fstream>

#include <ReArchNativeModule.internal.h>

#define DEFINE_NUMBER_TYPE(NUMTYPE) \
using NUMTYPE = NUMTYPE##_t;

    DEFINE_NUMBER_TYPE(int8)
    DEFINE_NUMBER_TYPE(int16)
    DEFINE_NUMBER_TYPE(int32)
    DEFINE_NUMBER_TYPE(int64)
    DEFINE_NUMBER_TYPE(uint8)
    DEFINE_NUMBER_TYPE(uint16)
    DEFINE_NUMBER_TYPE(uint32)
    DEFINE_NUMBER_TYPE(uint64)

#undef DEFINE_NUMBER_TYPE