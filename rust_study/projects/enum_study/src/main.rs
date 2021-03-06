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

    // enum Option<T>
    let some_number = Some(5);
    let some_string = Some("a string");

    let absent_number: Option<i32> = None;

    let x: i8 = 5;
    let y: Option<i8> = Some(5);

    // let sum = x + y;
    // ^ no implementation for `i8 + std::option::Option<i8>`

    // match フロー制御制御演算子
    let coin__quarter_alaska = Coin::Quarter(UsState::Alaska);
    let value_coin__quarter_alaska = value_in_cents(coin__quarter_alaska);
    println!(
        "The value of Quarter Alaska Coin is {}",
        value_coin__quarter_alaska
    );

    // Option<T>とのマッチ
    let five = Some(5);
    let six = plus_one(five);
    let none = plus_one(None);
    println!("The value of six is {:?}", six);
    println!("The value of Some(6) is {:?}", Some(6));
    println!("The value of none is {:?}", none);

    // _というプレースホルダー
    let some_u8_value = 0u8;
    match some_u8_value {
        1 => println!("one"),
        3 => println!("three"),
        5 => println!("five"),
        7 => println!("seven"),
        _ => (),
    }
    println!("The value of some_u8_value is {}", some_u8_value);

    // Some(3)のときだけコードを実行するmatch
    let mut some_u8_value = Some(0u8);
    match some_u8_value {
        Some(3) => println!("three"),
        _ => (),
    }

    // if let で簡潔なフロー制御
    if let Some(3) = some_u8_value {
        println!("three");
    }

    some_u8_value = Some(3);
    if let Some(3) = some_u8_value {
        println!("three");
    }

    let mut count = 0;
    let coin: Coin = Coin::Quarter(UsState::Alaska);
    // same ver.1
    // match coin {
    //     // {:?}州のクォーターコイン
    //     Coin::Quarter(state) => println!("State quarter from {:?}!", state),
    //     _ => count += 1,
    // }
    // same ver.2
    if let Coin::Quarter(state) = coin {
        println!("State quarter from {:?}!", state);
    } else {
        count += 1;
    }
}

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

// enum Option 標準ライブラリ

// enum Option<T> {
//     Some(T),
//     None,
// }

// match フロー制御演算子

#[derive(Debug)]
enum UsState {
    Alabama,
    Alaska,
    // ... などなど
}

enum Coin {
    Penny,
    Nickel,
    Dime,
    Quarter(UsState),
}

fn value_in_cents(coin: Coin) -> u32 {
    match coin {
        Coin::Penny => {
            println!("Lucky penny!");
            1
        }
        Coin::Nickel => 5,
        Coin::Dime => 10,
        Coin::Quarter(state) => {
            println!("State quarter from {:?}!", state);
            25
        }
    }
}

// Option<T> とのマッチ
fn plus_one(x: Option<i32>) -> Option<i32> {
    match x {
        None => None,
        Some(i) => Some(i + 1),
    }
}

fn plus_one_has_bag(x: Option<i32>) -> Option<i32> {
    match x {
        Some(i) => Some(i + 1),
        None => None, //non-exhaustive patterns: `None` not covered
    }
}
