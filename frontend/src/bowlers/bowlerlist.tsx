import { useEffect, useState } from "react";
import { Bowler } from "../types/Bowlers";

function BowlerList() {

    const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

    useEffect (() => {
        const fetchBowlerData = async () => {
            const rsp = await fetch('http://localhost:5297/BowlingLeague/GetTeamBowlers');
            const f = await rsp.json();
            setBowlerData(f);
        };
        fetchBowlerData();
    }, []);

     

    return (
        <>
            <div className="row">
                <h4 className="text-center">Bowling League</h4>
            </div>
            <table className="table table-boardered">
                <thead>
                    <tr>
                        <th>Bowler First Name</th>
                        <th>Bowler Middle Initial</th>
                        <th>Bowler Last Name</th>
                        <th>Bowler Team Name</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Zip</th>
                        <th>Phone Number</th>
                    </tr>
                </thead>
                <tbody>
                    {bowlerData.map((b) => (
                        <tr key={b.bowlerID}>
                            <td>{b.bowlerFirstName}</td>
                            <td>{b.bowlerMiddleInit}</td>
                            <td>{b.bowlerLastName}</td>
                            <td>{b.teamName}</td>
                            <td>{b.bowlerAddress}</td>
                            <td>{b.bowlerCity}</td>
                            <td>{b.bowlerState}</td>
                            <td>{b.bowlerZip}</td>
                            <td>{b.bowlerPhoneNumber}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    );
}

export default BowlerList;