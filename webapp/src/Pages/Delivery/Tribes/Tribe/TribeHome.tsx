import React, { useState } from "react";

import {
  createStyles,
  Table,
  ScrollArea,
  Button,
  Container,
  Title,
} from "@mantine/core";
import { Link, useParams } from "react-router-dom";
import Loading from "../../../../Components/Loading/Loading";
import { useTribe } from "../../../../Client/Tribe";
import { AddSquadModal } from "./AddSquadModal";
import { MutateSquad } from "../../../../Client/Squad";

const useStyles = createStyles((theme) => ({
  headline: {
    fontSize: 24,
    padding: 10,
    margin: 0,
  },
  buttonBar: {
    display: "flex",
    justifyContent: "flex-end",
    alignItems: "center",
    marginTop: 20,
  },
}));

interface TribeHomeProps {}

export function TribeHome(props: TribeHomeProps) {
  const id = +useParams().tribeId!;
  const { classes } = useStyles();
  const { items, loading } = useTribe({
    id: id,
  });
  const [addSquadModalOpen, setAddSquadModalOpen] = useState(false);
  const [addRoleModalOpen, setAddRoleModalOpen] = useState(false);

  if (loading) {
    return <Loading />;
  }

  const tribe = items.length > 0 ? items[0] : undefined;
  if (!id || !tribe) {
    return <div>Tribe not found</div>;
  }

  const squadRows = tribe.squads
    ? tribe.squads.map((row) => {
        const id = row.id.toString();
        return (
          <tr key={id}>
            <td>
              <Link to={`squads/${id}`}>{row.name}</Link>
            </td>
          </tr>
        );
      })
    : null;

  // const roleRows = roles
  //   ? roles.map((row) => {
  //       const id = row.id.toString();
  //       return (
  //         <tr key={id}>
  //           <td>
  //             <Link to={`${id}`}>{row.individual.first_name}</Link>
  //           </td>
  //           <td>
  //             <Link to={`${id}`}>{row.individual.last_name}</Link>
  //           </td>
  //           <td>
  //             <Link to={`${id}`}>{row.tribe_role_type.name}</Link>
  //           </td>
  //         </tr>
  //       );
  //     })
  //   : null;

  const submit = async (newSquad: MutateSquad) => {
    // await addSquad(newSquad);
    setAddSquadModalOpen(false);
  };

  // const submitRole = async (newRole: NewTribeRole) => {
  //   await addRole(newRole);
  //   setAddRoleModalOpen(false);
  // };

  return (
    <>
      <div>
        <Title order={3}>Tribe: {tribe.name}</Title>
        <Title order={4}>Squads</Title>
        <ScrollArea>
          <Table verticalSpacing="xs">
            <thead>
              <tr>
                <th>Name</th>
              </tr>
            </thead>
            <tbody>{squadRows}</tbody>
          </Table>
        </ScrollArea>
        <div className={classes.buttonBar}>
          <Button onClick={() => setAddSquadModalOpen(true)}>Add Squad</Button>
        </div>
        <Title order={4}>Tribe Roles</Title>
        <ScrollArea>
          <Table verticalSpacing="xs">
            <thead>
              <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Role</th>
              </tr>
            </thead>
            {/* <tbody>{roleRows}</tbody> */}
          </Table>
        </ScrollArea>
        <div className={classes.buttonBar}>
          <Button onClick={() => setAddRoleModalOpen(true)}>Add Role</Button>
        </div>
      </div>
      <AddSquadModal
        opened={addSquadModalOpen}
        onClose={() => setAddSquadModalOpen(false)}
        onSubmit={submit}
      />
      {/* <AddRoleModal
        tribeId={id}
        opened={addRoleModalOpen}
        onClose={() => setAddRoleModalOpen(false)}
        onSubmit={submitRole}
      /> */}
    </>
  );
}

export default TribeHome;
