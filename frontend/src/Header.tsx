import logo from "./JoelHiltonHeadshot.jpg";

function Header(props: any) {
  return (
    <header className="row">
      <div className="col align-self-center text-start">
        <img src={logo} alt="logo" />
      </div>
      <div className="col align-self-center text-start"></div>
    </header>
  );
}

export default Header;
