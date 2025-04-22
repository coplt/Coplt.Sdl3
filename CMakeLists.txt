cmake_minimum_required(VERSION 3.10)

if (WIN32)
    set(CMAKE_C_COMPILER "clang-cl.exe")
    set(CMAKE_CXX_COMPILER "clang-cl.exe")
endif ()

project(Coplt.Sdl3.Build)

add_subdirectory(SDL)
