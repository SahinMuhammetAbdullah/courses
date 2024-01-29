#include <winsock2.h>
#include <stdio.h>
#include <string.h>
#pragma comment(lib, "ws2_32.lib")

#define PORT 8080
#define MAX_CLIENTS 5

int main() {
    WSADATA wsa;
    SOCKET server_socket, client_socket;
    struct sockaddr_in server_addr, client_addr;
    int addrlen = sizeof(server_addr);
    char buffer[1024] = {0};
    const char* welcome_message = "Merhaba, bu bir Windows sunucusudur!";

    // Winsock başlat
    if (WSAStartup(MAKEWORD(2, 2), &wsa) != 0) {
        printf("Winsock başlatılamadı\n");
        return 1;
    }

    // Soket oluştur
    if ((server_socket = socket(AF_INET, SOCK_STREAM, 0)) == INVALID_SOCKET) {
        printf("Soket oluşturulamadı\n");
        WSACleanup();
        return 1;
    }

    // Sunucu adresi ve portu ayarla
    server_addr.sin_family = AF_INET;
    server_addr.sin_addr.s_addr = INADDR_ANY;
    server_addr.sin_port = htons(PORT);

    // Soketi belirtilen port ile ilişkilendir
    if (bind(server_socket, (struct sockaddr*)&server_addr, sizeof(server_addr)) == SOCKET_ERROR) {
        printf("Bağlama başarısız\n");
        closesocket(server_socket);
        WSACleanup();
        return 1;
    }

    // Bağlantıları dinlemeye başla
    if (listen(server_socket, MAX_CLIENTS) == SOCKET_ERROR) {
        printf("Dinleme başarısız\n");
        closesocket(server_socket);
        WSACleanup();
        return 1;
    }

    printf("Sunucu %d numaralı portu dinliyor\n", PORT);

    // Bağlantı kabul et
    if ((client_socket = accept(server_socket, (struct sockaddr*)&client_addr, &addrlen)) == INVALID_SOCKET) {
        printf("Bağlantı kabul edilemedi\n");
        closesocket(server_socket);
        WSACleanup();
        return 1;
    }

    printf("İstemci bağlandı\n");

    // İstemciye hoş geldin mesajını gönder
    send(client_socket, welcome_message, strlen(welcome_message), 0);

    // İstemciden gelen veriyi al
    int valread = recv(client_socket, buffer, sizeof(buffer), 0);
    printf("İstemci: %s\n", buffer);

    // Bağlı soketi kapat
    closesocket(client_socket);
    // Dinleme soketini kapat
    closesocket(server_socket);
    // Winsock'u temizle
    WSACleanup();

    return 0;
}
