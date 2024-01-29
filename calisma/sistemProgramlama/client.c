// Client side C program to demonstrate Socket programming on Windows
#include <winsock2.h>
#include <stdio.h>
#pragma comment(lib, "ws2_32.lib")

#define SERVER_IP "127.0.0.1"
#define PORT 8080

int main() {
    WSADATA wsa;
    SOCKET client_socket;
    struct sockaddr_in server_addr;
    char buffer[1024] = {0};
    const char* message_to_server = "Merhaba, ben istemci. Nasılsın?";

    // Winsock başlat
    if (WSAStartup(MAKEWORD(2, 2), &wsa) != 0) {
        printf("Winsock başlatılamadı\n");
        return 1;
    }

    // Soket oluştur
    if ((client_socket = socket(AF_INET, SOCK_STREAM, 0)) == INVALID_SOCKET) {
        printf("Soket oluşturulamadı\n");
        WSACleanup();
        return 1;
    }

    // Sunucu adresini ve portunu ayarla
    server_addr.sin_family = AF_INET;
    server_addr.sin_port = htons(PORT);

    // Sunucu IP adresini dönüştür
    server_addr.sin_addr.s_addr = inet_addr(SERVER_IP);
    if (server_addr.sin_addr.s_addr == INADDR_NONE) {
        printf("IP adresi dönüştürülemedi\n");
        closesocket(client_socket);
        WSACleanup();
        return 1;
    }

    // Sunucuya bağlan
    if (connect(client_socket, (struct sockaddr*)&server_addr, sizeof(server_addr)) < 0) {
        printf("Bağlantı kurulamadı\n");
        closesocket(client_socket);
        WSACleanup();
        return 1;
    }

    printf("Sunucuya bağlandım\n");

    // Sunucuya mesaj gönder
    send(client_socket, message_to_server, strlen(message_to_server), 0);

    // Sunucudan gelen cevabı al
    int valread = recv(client_socket, buffer, sizeof(buffer), 0);
    printf("Sunucu: %s\n", buffer);

    // Soketi kapat
    closesocket(client_socket);
    // Winsock'u temizle
    WSACleanup();

    return 0;
}
