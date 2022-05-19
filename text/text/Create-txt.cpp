#include <iostream>
#include <fstream>

int main() {
    std::ofstream o("Hello.txt");

    o << "Hello, World\n" << std::endl;

    return 0;
}