#pragma once

#include <new>
#include <memory>

/**
 * 内存分配相关宏定义
 * 这些宏允许我们在不修改大量代码的情况下替换内存分配器
 */

// 当前使用标准分配器，将来可以替换为自定义分配器
#ifndef USE_CUSTOM_ALLOCATOR
    // 基本分配宏
    #define NEW(Type) new Type
    #define NEW_ARRAY(Type, Count) new Type[Count]
    #define DELETE(Ptr) delete Ptr
    #define DELETE_ARRAY(Ptr) delete[] Ptr

    // 带参数构造的分配宏
    #define NEW_ARGS(Type, ...) new Type(__VA_ARGS__)
    
    // 带内存对齐的分配宏（使用标准库的aligned_alloc + placement new）
    #define NEW_ALIGNED(Type, Alignment) new (std::align_val_t(Alignment)) Type
    #define NEW_ARRAY_ALIGNED(Type, Count, Alignment) new (std::align_val_t(Alignment)) Type[Count]
    #define DELETE_ALIGNED(Ptr) delete Ptr
    #define DELETE_ARRAY_ALIGNED(Ptr) delete[] Ptr
#else
    // 将来实现自定义分配器时替换这些宏定义
    // #define NEW(Type) ...
    // #define DELETE(Ptr) ...
    // 等等
#endif

// 辅助宏，用于安全删除指针（删除后置空）
#define SAFE_DELETE(Ptr) if(Ptr) { DELETE(Ptr); Ptr = nullptr; }
#define SAFE_DELETE_ARRAY(Ptr) if(Ptr) { DELETE_ARRAY(Ptr); Ptr = nullptr; }

// 禁止复制的宏（可用于类声明中）
#define DISALLOW_COPY(TypeName) \
    TypeName(const TypeName&) = delete; \
    TypeName& operator=(const TypeName&) = delete;

// 禁止移动的宏
#define DISALLOW_MOVE(TypeName) \
    TypeName(TypeName&&) = delete; \
    TypeName& operator=(TypeName&&) = delete;

// 同时禁止复制和移动
#define DISALLOW_COPY_AND_MOVE(TypeName) \
    DISALLOW_COPY(TypeName) \
    DISALLOW_MOVE(TypeName)

