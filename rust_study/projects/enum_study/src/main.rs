enum IpAddrKind {
    V4,
    V6,
}

// struct IpAddr {
//     kind: IpAddrKind,
//     address: String,
// }

enum IpAddr {
    V4(u8, u8, u8, u8),
    V6(String),
}

fn main() {
    let four = IpAddrKind::V4;
    let six = IpAddrKind::V6;

    // structを使用
    // let home = IpAddr {
    //     kind: IpAddrKind::V4,
    //     address: String::from("127.0.0.1"),
    // };

    // let loopback = IpAddr {
    //     kind: IpAddrKind::V6,
    //     address: String::from("::1"),
    // };

    // enumで
    // let home = IpAddr::V4(String::from("127.0.0.1"));
    // let loopback = IpAddr::V6(String::from("::1"));

    // enumで（V4とV6で型を変える ver.
    let home = IpAddr::V4(127, 0, 0, 1);
    let loopback = IpAddr::V6(String::from("::1"));

    let m = Message::Write(String::from("hello"));
    m.call();
}

// 標準ライブラリ
struct Ipv4Addr {}

struct Ipv6Addr {}

enum IpAddr_lib {
    V4(Ipv4Addr),
    V6(Ipv6Addr),
}

// enum 幅広い種類の型が列挙子に埋め込まれている
enum Message {
    Quit,
    Move { x: i32, y: i32 },
    Write(String),
    ChangeColor(i32, i32, i32),
}

impl Message {
    fn call(&self) {
        // method body would be defined here
    }
}
