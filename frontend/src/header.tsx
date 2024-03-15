import logo from "./0901b49930684c93a91eaa9542e4a86d.png"

function Header(props: any) {
    return (
        <header className="row navbar navbar-dark bg-dark">
            <div className="col-4">
                <img src={logo} className="logo" alt="logo"></img>
            </div>
            <div className="col subtitle">
                <h1 className="text-white">{props.title}</h1>
                <h3 className="text-white">Look at the table below to see the players for the Marlins and Sharks!</h3>
            </div>
            
        </header>
    );
}

export default Header;